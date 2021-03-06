﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStud.Model
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class Korisnik 
    {
        protected string username;
        protected string usertype;
        protected string ime;
        protected string prezime;
        protected string datumRodjenja;
        protected string pol;
        protected string grad;
        protected string adresa;
        public Korisnik(string username,string usertype,string ime,string prezime,string datumRodjenja,string pol,string grad,string adresa)
        {
            this.username = username;
            this.usertype = usertype;
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.pol = pol;
            this.grad = grad;
            this.adresa = adresa;
            


        }

        public void setUserType(string usertype)
        {
            this.usertype = usertype;
          
        }
        public void setUserName(string username)
        {
            this.username = username;
            
        }
        public void setIme(string ime)
        {
            this.ime = ime;
           
        }
        public void setPrezime(string prezime)
        {
            this.prezime = prezime;
        
        }
        public void setDatumRodjenja(string datumRodjenja)
        {
            this.datumRodjenja = datumRodjenja;
     
        }
        public void setPol(string pol)
        {
            this.pol = pol;
            
        }
        public string getUserType()
        {
            return usertype;
        }
        public string getUserName()
        {
            return username;
        }
        public string getIme()
        {
            return ime;
        }
        public string getPrezime()
        {
            return prezime;
        }
        public string getDatumRodjenja()
        {
            return datumRodjenja;
        }
        public string getPol()
        {
            return pol;
        }
        public string getGrad()
        {
            return grad;
        }
        public void setGrad(string grad)
        {
            this.grad = grad;
        }
        public string getAdresa()
        {
            return adresa;
        }
        public void setAdresa()
        {
            this.adresa = adresa;
        }
    }
}
