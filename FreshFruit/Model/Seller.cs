using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFruit.Model
{
    class Seller
    {
        private string name;
        private BucketController bucket;
        private string v;
        private Controller.BucketController bucketcontroller;

        public Seller(string name, BucketContoller bucket)
        {
            this.name = name;
            this.bucket = bucket;
        }

        public Seller(string v, Controller.BucketController bucketcontroller)
        {
            this.v = v;
            this.bucketcontroller = bucketcontroller;
        }

        public List<Fruit> findAll()
        {
            return bucket.findAll();
        }

        public void addFruit(Fruit fruit)
        {
            this.bucket.addFruit(fruit);
        }
    }

    internal class BucketController
    {
        internal void addFruit(Fruit fruit)
        {
            throw new NotImplementedException();
        }

        internal List<Fruit> findAll()
        {
            throw new NotImplementedException();
        }

        public static implicit operator BucketController(BucketContoller v)
        {
            throw new NotImplementedException();
        }
    }

    public class BucketContoller
    {
    }
}
