using PersonOp;

Person Norbi=new Person("Varga Norbert",20,"Férfi");
Person jon = new Person();
Student Ati=new Student("Pataki Attila",21,"Férfi","Petrik",0);
Student joni = new Student();
Mentor Dani=new Mentor("Kő Dániel",55,"Férfi","Kezdő");
Mentor mentor=new Mentor();

Console.WriteLine(Norbi.introduce()+Norbi.getGoal());
Console.WriteLine(jon.introduce(),jon.getGoal());
Console.WriteLine(Ati.introduce(), Ati.getGoal());