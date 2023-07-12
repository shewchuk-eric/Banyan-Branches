using System;

class Program
{
    static void Main(string[] args)
    {
        string address;
        Address address1 = new Address("123 Some St","Boringville","ID","88991");
        address = address1.GetPlace();
        Reception reception = new Reception("Wedding","Two people are getting married.  Come wish them luck","8/17/2023","8:23PM",address, "gethitched@happyforever.com");
        reception.Short("Reception");
        reception.Standard();
        reception.Full();

        Address address2 = new Address("1830 That Pl","Grove","NY","10023");
        address = address2.GetPlace();
        Outdoor outdoor = new Outdoor("Revival","The great outdoor spiritual revival.","10/27/2023","9:31AM",address, "Gloriously brite but with moments of intense darkness.");
        outdoor.Short("Outdoor");
        outdoor.Standard();
        outdoor.Full();

        Address address3 = new Address("2021 Starry Night Ave.","Cambridge","MA","23008");
        address = address3.GetPlace();
        Lecture lecture = new Lecture("Big Surprises","Stephen Hawking died in 2018.  It was then he discovered he was wrong about God.","12/28/2023","Noon",address,"Someone Humble","400");
        lecture.Short("Lecture");
        lecture.Standard();
        lecture.Full();
    }
}