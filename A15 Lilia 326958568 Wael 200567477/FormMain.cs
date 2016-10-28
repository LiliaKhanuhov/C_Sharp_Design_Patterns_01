using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures.WithSingltonAppSettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            disableControls();
        }

        private void disableControls()
        {
            dataListBox.Enabled = false;
            optionsComboBox.Enabled = false;
            optionButton.Enabled = false;
            checkButton.Enabled = false;
            logoutbutton.Enabled = false;
            buttonLogin.Enabled = true;
        }

        private void enableControls()
        {
            dataListBox.Enabled = true;
            optionsComboBox.Enabled = true;
            optionButton.Enabled = true;
            checkButton.Enabled = true;
            logoutbutton.Enabled = true;
            buttonLogin.Enabled = false;
        }

        private User m_LoggedInUser;
        private List<User> m_listFriends = new List<User>();

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login("801621103232694", "user_friends");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
             
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
            

            picture_smallPictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);

            fillOptionCombobox();
           // fillMyGenderCombobox();

            enableControls();
           
        }

        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void fetchFriends()
        {
            if (m_listFriends != null)
            {
                m_listFriends.Clear();
            }
            foreach (User friend in m_LoggedInUser.Friends)
            {
                m_listFriends.Add(friend);
            }
        }




        private void listBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedItem();
        }

        private void displaySelectedItem()
        {
            if (dataListBox.SelectedItems.Count == 1)
            {
                Page selectedMo = dataListBox.SelectedItem as Page;
                FacebookObjectCollection<Album> url = selectedMo.Albums;
                if (url != null)
                {
                    pictureBox1.LoadAsync(url[2].PictureAlbumURL);
                }
                else
                {
                    picture_smallPictureBox.Image = picture_smallPictureBox.ErrorImage;
                }
            }
        }

        private void fillOptionCombobox()
        {
            optionsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] i_Genders = new string[] { "Movies", "Books", "Music" };
            optionsComboBox.Items.AddRange(i_Genders);
        }

        private void CheckOkButton_Click(object sender, EventArgs e)
        {
            checkRatio();
        }

        private void checkRatio()
        {

            if (m_LoggedInUser.Friends.Count == 0)
            {
                resultMessageTextBox.Text = "You are poor ,get a life!!";
                return;
            }

            int counterBoys = 0;
            int counterGirls = 0;

            foreach (User friend in m_LoggedInUser.Friends)
            {
                String friendGender = friend.Gender.ToString();

                if (friendGender == "female") 
                {
                    counterGirls += 1;
                }
                else
                {
                    counterBoys += 1;
                }
            }

            float result;
           // String genderUser = myGendercomboBox.SelectedItem as String;
            result = counterBoys / m_LoggedInUser.Friends.Count;

            if (result > 0.66666)
            {
                if (m_LoggedInUser.Equals("female"))
                {
                    resultMessageTextBox.Text = "Well done !!! boys love you !!!";
                }
                else
                {
                    resultMessageTextBox.Text = "You are nerd !!";
                }
            }
            else if (result < 0.3333)
            {
                if (m_LoggedInUser.Equals("female"))
                {
                    resultMessageTextBox.Text = "You are geek !!";
                }
                else
                {
                    resultMessageTextBox.Text = "Well done !!! girls love you !!!";
                }
            }
            else
            {
                resultMessageTextBox.Text = "The fine. But can also be more";
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            clear();
            disableControls();

        }

        private void clear()
        {
            picture_smallPictureBox.Image = null;
            pictureBox1.Image = null;
            dataListBox.Items.Clear();
            optionsComboBox.Items.Clear();
            resultMessageTextBox.Text = null;
        }

        private void SearchOkButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            dataListBox.Items.Clear();
            String typeOfData = optionsComboBox.SelectedItem as String;
            getSharedData(typeOfData);

        }

        private void getSharedData(String typeOfData)
        {
            

            dataListBox.DisplayMember = "Name";

            fetchFriends();

            FacebookObjectCollection<Page> userLogInU = FacebookService.GetCollection<Page>(typeOfData , m_LoggedInUser.Id);

            foreach (User friend in m_listFriends)
            {
                FacebookObjectCollection<Page> friendMovies = FacebookService.GetCollection<Page>(typeOfData, friend.Id);

                foreach (Page usermovie in userLogInU)
                {
                    foreach (Page movie in friendMovies)
                    {
                        if (movie.Name == usermovie.Name && !dataListBox.Items.Contains(movie.Name))
                        {
                            dataListBox.Items.Add(movie);
                        }
                    }
                }
            }

        } 
    }
    }

