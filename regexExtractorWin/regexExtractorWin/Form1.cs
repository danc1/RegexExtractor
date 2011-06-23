using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace regexExtractorWin {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void btnSearch_Click(object sender, EventArgs e) {

      try {
        
        string strFile;

        StreamReader sr = new StreamReader(txtFile.Text, Encoding.Default);
        strFile = sr.ReadToEnd();
        sr.Close();

        System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(txtRegex.Text , RegexOptions.IgnoreCase);

        MatchCollection matches = r.Matches(strFile);

        textBox1.Text = "";


        Dictionary<string, int> count = new Dictionary<string, int>();

        //HashSet<string> hs = new HashSet<string>();

        foreach (Match match in matches) {
          if (count.ContainsKey(match.Value)) {
            count[match.Value]++;
          } else {
            count[match.Value] = 1;
          }
        }

        StringBuilder sb = new StringBuilder();

        count
          .OrderByDescending(x => x.Value)
          .ToList()
          .ForEach(x => sb.AppendLine(string.Format("{0,4:G}", x.Value) + ": " + x.Key));

        textBox1.Text = sb.ToString();

      }
      catch (Exception ex) {
        MessageBox.Show(ex.Message);
      }

      

    }



  }
}
