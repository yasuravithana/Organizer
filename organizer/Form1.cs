using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace organizer
{
    [Serializable()]

    public partial class Form1 : Form
    {
        
        const string FileName = @"..\data\abc.bin";
        
        public Form1()
        {
            InitializeComponent();
            initialize();
        }
            


        private void initialize()
        {
            this.Visible = false;
            Directory.CreateDirectory(@"..\data");
            BinaryFormatter deserializer;
            Event loaded;

            Stream TestFileStream;
            IEnumerable<string> e= Directory.EnumerateFiles(@"..\data", "*.yo");
            for (int i = 0; i < e.Count(); i++)
            {
                TestFileStream = File.OpenRead(@"..\data\"+e.ElementAt(i));
                deserializer = new BinaryFormatter();
                loaded = (Event)deserializer.Deserialize(TestFileStream);
                TestFileStream.Close();
                if(!(loaded.nextBegin.CompareTo(System.DateTime.Today)>0))
                {
                    if (!(loaded.nextEnd.CompareTo(System.DateTime.Today) < 0))
                    {
                        notifyIcon1.BalloonTipText = loaded.getDescription();
                        notifyIcon1.ShowBalloonTip(0);
                    }
                    else
                    {
                        //do this if the next has passed
                    }

                    int dwStartTime = System.Environment.TickCount;

                    while (true)
                    {

                        if (System.Environment.TickCount - dwStartTime > 10000) break; //10000 milliseconds 

                    }
                
                
                
                
                }

                
                
            }
           

          
            
            Object[] comboList = new Object[28];
            for (int i = 0; i < 28; i++)
            {
                comboList[i] = (i + 1).ToString();
            }
            when.Items.AddRange(comboList);


            

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Event ev;
            (ev=new Event()).save(this);
            next.Text=("The next reminders are scheduled on the days from "+ev.nextBegin.ToShortDateString()+" to "+ev.nextEnd.ToShortDateString()+".");
            notifyIcon1.BalloonTipText = "Saved!!!!";
            notifyIcon1.ShowBalloonTip(0);
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Visible =false;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        
    }

    [Serializable()]
    public class Event 
    {
        private String title;
        private String description;
        private int often;
        private int when;
        private int days;
        private int before;
        const string FileName = @"..\data\";
        public DateTime nextBegin,nextEnd;
        public void save(Form1 form)
        {
            title = form.title.Text;
            description = form.description.Text;
            often = form.often.SelectedIndex;
            when = form.when.SelectedIndex;
            days = int.Parse(form.days.Text);
            before = form.before.SelectedIndex;

            calc();

            Stream TestFileStream = File.Create(FileName+title+".yo");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(TestFileStream, this);
            TestFileStream.Close();
        }


        private void calc()
        {
            if (often == 0)
            {
                nextEnd = new DateTime(System.DateTime.Today.Year, System.DateTime.Today.Month, when + 1);
                if(nextEnd.CompareTo(System.DateTime.Today)<0)
                    nextEnd=nextEnd.AddMonths(1);
                //has to check for == 0
                nextBegin = nextEnd.AddDays(-1 * days);
            }
        }

        public string getDescription()
        {
            return description;
        }
    }


   
}
