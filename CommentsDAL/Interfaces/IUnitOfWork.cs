﻿using CommentsDAL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsDAL.Interfaces
{
    public interface IUnitOfWork
    {
        ICommentsRepository CommentsRepository { get; }

        IReactionsRepository ReactionsRepository { get; }

        Task SaveChangesAsync();
    }
}