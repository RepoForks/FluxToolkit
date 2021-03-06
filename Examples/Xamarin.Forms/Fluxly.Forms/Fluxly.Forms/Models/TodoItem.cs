﻿using System;
using GalaSoft.MvvmLight;

namespace Fluxly.Forms.Models
{
    /// <summary>
    /// Data model for a todo item
    /// </summary>
    public class TodoItem : ViewModelBase
    {
        private string _id;
        private string _text;
        private bool _isComplete;

        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                Set(() => Id, ref _id, value);
            }
        }
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                Set(() => Text, ref _text, value);
            }
        }
        public bool IsComplete
        {
            get
            {
                return _isComplete;
            }
            set
            {
                Set(() => IsComplete, ref _isComplete, value);
            }
        }
    }

}
