﻿using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure
{

    public class Node<T>
    {
        /// <summary>
        /// data member veriable contain data of node
        /// </summary>
        public T data;

        /// <summary>
        /// Next member veriable contain information of next node.
        /// </summary>
        public Node<T> next;

        public Node(T data)
        {
            this.data = data;
        }
    }

}
