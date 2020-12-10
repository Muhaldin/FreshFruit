FreshFruit


Aplikasi ini adalah aplikasi penjualan buah dengan bucket dengan menggunakan konsep MVC yang ditekankan agar mahasiswa paham konsep MVC

Scope and Functionalities

1. User dapat menekan tombol Add

2. User dapat menampilkan gambar buah

3. User akan melihat warning


How Does it Works?


Apa fungsi BucketEventListener?


tempat untuk menghandle event ketika action dijalankan berhasil (onSucceed) gagal (onFailed) 2. Logika Pembahasan

Diawali pada MainWindow.xaml.cs, dengan membuat sebuah instance dari masing - masing class.


Seller Toni;


        public MainWindow()
        
        
        {
        
            InitializeComponent();

            Bucket cartFruit = new Bucket(2);
            
            BucketController bucketController = new BucketController(cartFruit, this);

            Toni = new Seller("Toni", bucketController);
            
            ListBoxBucket.ItemsSource = cartFruit.findAll();
            
        }

Pada baris pertama digunakan untuk membuat instance Seller dengan nama Toni, lalu diikuti dengan membuat instance Bucket dengan keranjang buah dan BucketController dengan nama bucketController dan memberikan argumen keranjang buah dan context this.

lalu mendeklarasikan dari instance Seller yang telah dibuat tadi, dengan memberikan argument "Toni" dan bucketController. Setelah itu memasukkan semua item dari keranjang buah ke listbox


private void AddApple_Click(object sender, RoutedEventArgs e)

        {
            Fruit apple = new Fruit("Apple");
            
            Toni.addFruit(Pisang);
        }
        
Lalu dalam function AddApple_Click, digunakan untuk menambahkan item Apple pada cart nya. Berlaku juga untuk AddBanana_Click, AddOrange_Click, dll.


public void onFailed (string msg)

        {
            MessageBox.Show(msg, "Warning");
        }

        public void onSucceed (string msg)
        {
            ListBoxBucket.Items.Refresh();
        }
        
        
Kode diatas digunakan ketika failed maka akan ditampilkan sebuah popup warning dan jika berhasil akan mengupdate ata merefresh listBoxnya

Lalu masuk ke model/Seller.cs, digunakan sebagai model atau kerangka atau seller. Dalam class ini terdapat instance dari BucketController


public List<Fruit> findAll ()

        {
            return this.bucketController.findAll();
        }

        public void addFruit (Fruit fruit)
        {
            this.bucketController.addFruit(fruit);
        }
        
Selain itu ada function findAll () yang digunakan untuk mengambil data dari bucketController. Sedangkan addFruit () digunakan untuk menambah data ke bucketController

 
 public string name { get; set; }
        
        public Fruit(string name)
        {
            this.name = name;
        }

        public string getName ()
        {
            return this.name;
        }
        
Pada model/Fruit.cs hanya terdapat kerangka untuk fruit saja, terdapat getter dan setter untuk nama.


private int capacity;


        private List<Fruit> fruits;

        public Bucket (int capacity)
        {
            this.capacity = capacity;
            this.fruits = new List<Fruit>();
        }

        public void insert (Fruit fruit)
        {
            this.fruits.Add(fruit);
        }

        public void remove (int pos)
        {
            this.fruits.RemoveAt(pos);
        }

        public List<Fruit> findAll ()
        {
            return this.fruits;
        }

        public int getCapacity ()
        {
            return this.capacity;
        }

        public int countItems ()
        {
            return this.fruits.Count();
        }


Pada model/Bucket.cs terdapat method yang fungsinya bermacam - macam sesuai nama fungsinya. Terdapat juga list untuk menampung data yang telah ditambahkan.

 void onSucceed(string msg);
 
 void onFailed(string msg);
 
Pada model/BucketEvenListener hanya terdapat dua function untuk menghandle event onSucceed dan onFailed

 public void addFruit (Fruit fruit)
 
        {
            if (isBucketOverload())
            {
                bucketEventListener.onFailed("opps keranjang sudah penuh gan!");
            } else
            {
                this.bucket.insert(fruit);
                bucketEventListener.onSucceed("yeeayy buah berhasil ditambahkan!");
            }
        }
        
Pada controller/BucketController.cs terdapat function addFruit yang berguna untuk menambah data pada list. Namun bucket dicek terlebih dahulu apakah overload atau tidak.

public bool isBucketOverload ()

        {
            return bucket.countItems() >= bucket.getCapacity();
        }
        
Kode diatas digunakan untuk mengecek apakah bucket overload atau tidak

 public void removeFruit (Fruit fruit)
 
        {
            for (int itemPos = 0; itemPos < bucket.countItems(); itemPos++)
            {
                if (bucket.findAll ().ElementAt(itemPos).getName() == fruit.name)
                {
                    bucket.remove(itemPos);
                    bucketEventListener.onSucceed("yeayyy berhasil dihapus");
                }
            }
        }
        
Sedangkan kode diatas untuk menghapus item pada list.
