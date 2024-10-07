
var students =new string[4];
var notes = new int[4];

Console.WriteLine("Student name: ");
students[0] = Console.ReadLine() ?? "Empty";// ?? means default value if no input

Console.WriteLine("Student note: ");
notes[0] = Convert.ToInt32(Console.ReadLine() ?? "0");// ?? means default value if no input


foreach(var student in students){

Console.WriteLine(student);
}

foreach(var note in notes){

    Console.WriteLine(note);
}

var multidim_array = new int[3,3];

multidim_array[0,0]=34;
multidim_array[0,1]=56;
multidim_array[0,2]=67;
multidim_array[1,0]=45;
multidim_array[1,1]=12;
multidim_array[1,2]=89;

