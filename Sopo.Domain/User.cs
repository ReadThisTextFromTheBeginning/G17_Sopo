using Sopo.Repository.BaseTypes;
using Sopo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Repository
{
    public class User : BaseDeletable
    {
        public User()
        {
            SentRelationships = new List<Relationship>();
            ReceivedRelationships = new List<Relationship>();
            SentMessages = new List<Message>();
            Ratings = new List<Rating>();
            Libraries = new List<Library>();
            Pages = new List<Page>();
            Posts = new List<Post>();
            Groups = new List<Group>();
            this.Date = DateTime.Now;
        }

        public string FirstName
        {
            get { return this.FirstName; }
            set
            {
                if (value.Length <= 2 || value.Length > 40)
                    throw new Exception("User Field Firstname Has Some Invalid Arguments!");
                this.FirstName = value;
            }
        }
        public string LastName
        {
            get { return this.FirstName; }
            set
            {
                if (value.Length <= 3 || value.Length > 40)
                    throw new Exception("User Field Lastname Has Some Invalid Arguments!");
                this.LastName = value;
            }
        }
        public string Email
        {
            get { return this.FirstName; }
            set
            {
                if (value.Length <= 8 ||
                    value.Length > 40 ||
                    !value.Contains("@") ||
                    !value.Contains("."))
                    throw new Exception("User Field Email Has Some Invalid Arguments!");
                this.Email = value;
            }
        }
        public string Password
        {
            get { return this.FirstName; }
            set
            {
                if (value.Length <= 6 || value.Length > 40)
                    throw new Exception("User Field Password has some Invalid Argumets!"); // this is not finished yet!
                this.Password = value;
            }
        }

        public virtual ICollection<Relationship> SentRelationships { get; set; }
        public virtual ICollection<Relationship> ReceivedRelationships { get; set; }
        public virtual ICollection<Message> SentMessages { get; set; }
        public virtual ICollection<Message> ReceivedMessages { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Library> Libraries { get; set; }
        public virtual ICollection<Page> Pages { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Phone> PhoneNumbers { get; set; }
        public virtual Profile Profile { get; set; }

        public override string ToString()
        {
            return "ID - " + ID + ", Firstname - " + FirstName + ", Lastname - " + LastName + ", Username - " + Email + ", Password - " + Password + ";";
        }
        public override bool Equals(object obj)
        {
            if (obj is User)
            {
                User u = (User)obj;
                if (
                    this.Email == u.Email &&
                    this.Password == u.Password &&
                    this.FirstName == u.FirstName &&
                    this.LastName == u.LastName
                    )
                {
                    return true; //Keep in mind thad, the if statement does not compare "ID" fields of the two objects                }
                }
            }
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
