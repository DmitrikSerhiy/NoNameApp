﻿using System;
using System.Collections.Generic;
using Model.Entities.Common;

namespace Model.Entities {
    public sealed class Dmo : Entity {
        public string Name { get; set; }
        public string MovieTitle { get; set; }
        public short DmoStatus { get; set; }
        public string ShortComment { get; set; }
        public short? Mark { get; set; }
        public string BeatsJson { get; set; }


        public NnaUser NnaUser { get; set; }
        public Guid NnaUserId { get; set; }

        public ICollection<DmoCollectionDmo> DmoCollectionDmos { get; set; }
    }
}
