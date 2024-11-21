using System;
using UnityEngine;

namespace InventorySystem
{
    [Serializable]
    public class InventoryCell
    {
        private Vector2Int _position;
        private InventoryItem _item;
        
        public InventoryCell(Vector2Int position)
        {
            _position = position;
        }
        
        
        
    }
}