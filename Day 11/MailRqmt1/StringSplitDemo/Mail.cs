using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplitDemo
{
    class Mail
    {
        private long _id;
        public long ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _to;
        public string To
        {
            get { return _to; }
            set { _to = value; }
        }

        private string _from;
        public string From
        {
            get { return _from; }
            set { _from = value; }
        }

        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        private string _content;
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        private DateTime _receivedDate;
        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
            set { _receivedDate = value; }
        }

        private double _size;
        public double Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public Mail()
        {
        }
        public Mail(long _id, string _to, string _from, string _subject, string _content, DateTime _receivedDate, double _size)
        {
            ID = _id;
            To = _to;
            From = _from;
            Subject = _subject;
            Content = _content;
            ReceivedDate = _receivedDate;
            Size = _size;
        }
        public override string ToString()
        {
            return string.Format("ID:{0}\nTo:{1}\nFrom:{2}\nSubject:{3}\nContent:{4}\nReceivedDate:{5}\nSize:{6}\n",
                 ID, To, From, Subject, Content, ReceivedDate.ToString("dd-mm-yyyy", null),
                 Size.ToString("0.0"));
        }
        public override bool Equals(object obj)
        {
            Mail m1 = obj as Mail;
            if (m1.To == To && m1.From == From && m1.Subject == Subject)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
