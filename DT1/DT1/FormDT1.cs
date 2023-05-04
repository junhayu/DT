using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Threading;
using System.Windows.Controls;
using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using devDept.Eyeshot.Translators;

namespace DT1
{
    public partial class formMode1 : Form
    {

        public formMode1()
        {
            InitializeComponent();
            //string path = @"c:\Users\Junha Desktop\Desktop\용역\생산연\신규\통합 깃\DT1\DT1\sample data\Placa_muestras.stp";
            //ReadSTEP ro = new ReadSTEP(path);
            //ro.DoWork();
            //Entity[] entList = ro.Entities;
            ////Dictionary<string, Material> matList = ro.Materials;

            //design1.Entities.Add(entList[0], Color.LightBlue);
        }

    }
}
