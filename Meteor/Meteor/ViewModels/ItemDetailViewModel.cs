﻿using System;

namespace Meteor {
    public class ItemDetailViewModel : BaseViewModel {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null) {
            if (item != null) {
                item = null;
                Title = item.Text;
                Item = item;
            }
        }
    }
}
