﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class CollectionBoard
    {

        private int totalScore;
        private int totalValue;


        public int TotalScore
        {
            get { return totalScore; }
            set { totalScore = value; }
        }

        public int TotalValue
        {
            get { return totalValue; }
            set { totalValue = value; }
        }


        public CollectionBoard()
        {
            totalScore = 0;
            totalValue = 0;
        }


        // public void Display()
        //{
        //   Console.WriteLine($"Total Score: {totalScore}");
        //Console.WriteLine($"Total Value: {totalValue}");
        // }
    }
}
