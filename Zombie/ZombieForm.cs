﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zombie.Functions;
using Zombie.Web;

namespace Zombie
{
    public partial class ZombieForm : Form
    {
        public ZombieForm()
        {
            InitializeComponent();


        }

        private void ZombieForm_Load(object sender, EventArgs e)
        {
            Client.Start("192.168.0.245", 1337);

            Client.Send(Encoding.UTF8.GetBytes("abc"));
            Client.Send(Encoding.UTF8.GetBytes("abcd"));
            //   Client.Debug();

            // Client.Send(Encoding.UTF8.GetBytes("Reliable"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Client.Debug();
        }
    }
}
