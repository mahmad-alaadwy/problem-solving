using proplems_solved.LinkedListt;

LinkedListt<int> x =new LinkedListt<int>();

Node<int> y = new Node<int>();
y.Value = 5;
Node<int> v = new Node<int>();
v.Value = 6;

Node<int> m = new Node<int>();
m.Value = 9;

Node<int> f = new Node<int>();
f.Value = 1;

Node<int> mid = new Node<int>();
f.Value = 7;


x.InsertAt(0, y);
x.InsertAt(1, v);
x.Append(m);
x.PrePend(f);
x.InsertAt(1, mid);


x.Traverse();