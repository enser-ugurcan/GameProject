﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface Icampaign
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}