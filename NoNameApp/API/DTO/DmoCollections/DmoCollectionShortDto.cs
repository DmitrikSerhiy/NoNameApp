﻿using System;

namespace API.DTO.DmoCollections {
    public class DmoCollectionShortDto {
        public Guid? Id { get; set; }
        public String CollectionName { get; set; }
        public Int32 DmoCount { get; set; }
    }
}
