using Session_03;

Person p = new Person("sdf", 30);
Console.WriteLine(p.GetName());
Professor pro = new Professor("sdfs", 30, "rank", new Course[] { new Course("fsdf", "fsdf")});
Console.WriteLine(pro.GetName());
