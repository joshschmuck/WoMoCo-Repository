﻿using System.Collections.Generic;
using WoMoCo.Models;
using WoMoCo.ViewModels;

namespace WoMoCo.Services
{
    public interface ICommService
    {
        void DeleteComm(int id);
        IList<Comm> GetAllComms();
        Comm GetCommById(int id);
        IList<CommViewModel> GetCommsByUserName(string uid);
        
        int GetCountCurrentUserNewMessages(string uid);
        void SaveComm(Comm comm, string uid);
    }
}