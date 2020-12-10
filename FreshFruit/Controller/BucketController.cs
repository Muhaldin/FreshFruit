using FreshFruit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreshFruit.Controller
{
    class BucketController
    {
        private Bucket bucket;
        private BucketEventListener eventListener;

        public BucketController(Bucket bucket, BucketEventListener eventListener)
        {
            this.bucket = bucket;
            this.eventListener = eventListener;
        }

        public BucketController(Bucket keranjangBuah, MainWindow mainWindow)
        {
        }

        public void addFruit(FreshFruit fruit)
        {
            if (bucketIsOverload())
            {
                eventListener.onFailed("Ops, keranjang penuh");
            }
            else
            {
                this.bucket.insert(fruit);
                eventListener.onSucceed("Yey, Berhasil di tambahkan");
            }

            public void removeFruit(FreshFruit fruit)
            {
                for (int itemPosition = 0; itemPosition < bucket.countItem(); itemPosition++)
                {
                    if (bucket.findAll().ElementAt(itemPosition).getname() == fruit.getname)
                    {
                        bucket.remove(itemPosition);
                        eventListener.onSucceed("Yey, berhasil di hapus");
                    }
                }
            }
        }

        private bool bucketIsOverload()
        {
            throw new NotImplementedException();
        }

        public List<Fruit> findAll()
        {
            return this.bucket.findAll();
        }
    }
}
