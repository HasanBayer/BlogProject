﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsletterDal;

        public NewsLetterManager(INewsLetterDal newsletterdal)
        {
            _newsletterDal = newsletterdal;
        }

        public void AddNewsLetter(NewsLetter newsLetter)
        {
            _newsletterDal.Insert(newsLetter);
        }
    }
}