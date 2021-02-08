//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;

//namespace PizzaToppings
//{
//    class Seagull : Bird, IFlyer
//    {
//        public void Fly(int howFarInMiles)
//        {
//            var collection = new NathansMagicCollection();
//            collection.First();
//        }
//    }

//    abstract class Bird
//    {

//    }
//    enum Color
//    {
//        White,Black,Green,Yellow
//    }

//    interface IFlyer
//    {
//        void Fly(int howFarInMiles);
   
//    }
//    public class NathansMagicCollection : IEnumerable<int>
//    {
//        public IEnumerator<int> GetEnumerator()
//        {
//            throw new NotImplementedException();
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return GetEnumerator();
//        }
//    }
//}
