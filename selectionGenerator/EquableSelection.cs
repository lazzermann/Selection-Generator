﻿using System;

namespace selectionGenerator
{
    public class EquableSelection : Selection
    {
        private int leftBorder { get; set; }
        private int rightBorder{get; set;}

        public EquableSelection() : base() {}
        
        public override void generateSelection()
        {
            Random nue = new Random();

            int n = 1; 
            double value = 0;
            double[] primeSelection;

            Console.WriteLine("Input the count of numbers in selection");
            n = Convert.ToInt32(Console.ReadLine());

            primeSelection = GeneratePrimarySelection(n);

            Console.WriteLine("Input the left and right border of interval");

            leftBorder = Convert.ToInt32(Console.ReadLine());
            rightBorder = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                value = leftBorder + (rightBorder - leftBorder) * primeSelection[i];
                selection.Add(Math.Round(value,2));
            }
        }
    }
}
