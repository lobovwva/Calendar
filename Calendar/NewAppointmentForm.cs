using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class NewAppointmentForm : Form
    {
        private DateTime _currentDate;
        private Appointment _appointment;
        public NewAppointmentForm(DateTime currentDate, Appointment appointment)
        {
            InitializeComponent();
            _appointment = appointment;
            _currentDate = currentDate;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) => textBox3.Enabled = checkBox1.Checked;

        private void button2_Click(object sender, EventArgs e) => Close();

        private void button1_Click(object sender, EventArgs e)
        {
            if (_appointment == null)
            {
                SaveAppointment();
            }
            else
            {
                UpdateAppointment();
            }
            Close();
        }
        
        private void SaveAppointment()
        {
            var appointment = new Appointment()
            {
                Title = textBox1.Text,
                EndDate = dateTimePicker1.Value,
                Description = textBox2.Text,
                IsCompleted = false 
            };
            CalendarSQL.AddAppointment(appointment);
        }

        private void UpdateAppointment()
        {
            _appointment.Title = textBox1.Text;
            _appointment.EndDate = dateTimePicker1.Value;
            _appointment.Description = textBox2.Text;
            

            if (_appointment.ID == 0)
            {
                _appointment.ID = CalendarSQL.GetNextAppointmentID();
                CalendarSQL.AddAppointment(_appointment);
            }
            if (checkBox1.Checked)
            {
                _appointment.IsCompleted = checkBox1.Checked;
                _appointment.Result = textBox3.Text;
            }
            CalendarSQL.UpdateAppointment(_appointment);
        }

        private void NewAppointmentForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = _currentDate;
            if (_appointment != null)
            {
                textBox1.Text = _appointment.Title;
                textBox2.Text = _appointment.Description;
                textBox3.Text = _appointment.Result;
                dateTimePicker1.Value = _appointment.EndDate;
                checkBox1.Checked = _appointment.IsCompleted;
            }
        }
    }
}
