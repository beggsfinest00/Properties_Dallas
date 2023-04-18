using System;

namespace Properties_Dallas
{
    class Car
    {
        // makes a vaule of model.
        private string model;

        //retrives the model name and rurnts is and set the value of it to the object
        public string Model { get { return model; } set { model = value; } }
        
        //autmaticaly gets and sets make vaule.
        public string Make { get; set; }
    }
}
