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

namespace FB_App
{
    public abstract class EventsFinderBy
    {
        public List<User> ListOfPeopleWhoAttendToEvent { get; private set; }

        protected List<Event> ListOfValidEvents { get; private set; }
        
        public int NumberOfEventAttenders { get; private set; }

        protected readonly object sr_AddToListLock = new object();

        public EventsFinderBy()
        {
            ListOfPeopleWhoAttendToEvent = new List<User>();
            ListOfValidEvents = new List<Event>();
        }

        public void FetchUserEventsByAttendings(User i_User, ListBox i_ListBoxEventsByMinimumNumberOfParticipants, TextBox i_MinimumNumber, System.Windows.Forms.BindingSource i_BindingSource)
        {
            try
            {
                if (i_User != null)
                {
                    ListOfValidEvents.Clear();
                    i_ListBoxEventsByMinimumNumberOfParticipants.Invoke(new Action(() =>
                    {
                        i_ListBoxEventsByMinimumNumberOfParticipants.DataSource = null;
                        i_ListBoxEventsByMinimumNumberOfParticipants.Items.Clear();
                    }));

                    bool isNumber = checkIfValidInput(i_MinimumNumber.Text);

                    if (isNumber)
                    {
                        int intNumber = int.Parse(i_MinimumNumber.Text);

                        if (intNumber >= 0)
                        {
                            GetValidEvents(intNumber, i_User);
                            NumberOfEventAttenders = ListOfValidEvents.Count;

                            if(NumberOfEventAttenders > 0)
                            {
                                    lock (sr_AddToListLock)
                                    {
                                        i_BindingSource.DataSource = ListOfValidEvents;
                                        i_ListBoxEventsByMinimumNumberOfParticipants.Invoke(new Action(() =>
                                            i_ListBoxEventsByMinimumNumberOfParticipants.DataSource = i_BindingSource));
                                    }
                            }
                            else
                            {
                                MessageBox.Show("There are no events that match!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error! Please enter a positive number only.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error! Please enter numbers only.");
                    }
                }
                else
                {
                    throw new Exception("You must be logged in, in order to proceed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private bool checkIfValidInput(string i_StringToCheck)
        {
            int intNumber;
            bool isNumber = int.TryParse(i_StringToCheck, out intNumber);

            return isNumber;
        }

        public void LoadPictureAndNumberOfAttenders(ListBox i_Events, PictureBox i_PictureBox, TextBox i_TextBox)
        {
            if (i_Events.SelectedItems.Count == 1)
            {
                Event selectedEvent = i_Events.SelectedItem as Event;
                i_PictureBox.LoadAsync(selectedEvent.PictureNormalURL);
                i_TextBox.Clear();
                i_TextBox.Text = selectedEvent.AttendingUsers.Count.ToString();
            }
        }

        public void LoadListOfAttenders(Event i_Event)
        {
            ListOfPeopleWhoAttendToEvent.Clear();
            if (i_Event.AttendingUsers.Count > 0)
            {
                foreach (User attender in i_Event.AttendingUsers)
                {
                    ListOfPeopleWhoAttendToEvent.Add(attender);
                }
            }
        }

        public void AttendToEvent(ListBox i_Events)
        {
            if (i_Events.SelectedItems.Count == 1)
            {
                Event fbEvent = i_Events.SelectedItem as Event;
                fbEvent.Respond(Event.eRsvpType.Attending);
                MessageBox.Show("You are now attending to the event!");
            }
        }

        public abstract void GetValidEvents(int i_Number, User i_User);
    }
}