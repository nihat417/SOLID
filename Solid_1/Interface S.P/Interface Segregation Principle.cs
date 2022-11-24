using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_1.Interface_S.P;

#region Beore

//interface IPhone
//{
//    void Call();
//    void TakePhoto();
//    void MakeVideo();
//    void BrowseInternet();
//}
//class Phone : IPhone
//{
//    public void Call() => Console.WriteLine("zenf");
//
//    public void TakePhoto() => Console.WriteLine("foto");
//
//    public void MakeVideo() => Console.WriteLine("video");
//
//    public void BrowseInternet() => Console.WriteLine("inetde axtaris");
//}
//
//class Photograph
//{
//    public void TakePhoto(Phone phone)
//    {
//        phone.TakePhoto();
//    }
//}
//class Camera : IPhone
//{
//    public void Call() { }
//    public void TakePhoto()
//    {
//        Console.WriteLine("foto");
//    }
//    public void MakeVideo() { }
//    public void BrowseInternet() { }
//}

#endregion

#region After

interface ICall
{
    void Call();
}
interface IPhoto
{
    void TakePhoto();
}
interface IVideo
{
    void MakeVideo();
}
interface IWeb
{
    void BrowseInternet();
}

class Camera : IPhoto
{
    public void TakePhoto()
    {
        Console.WriteLine("fotokamerA ile sekl");
    }
}

class Phone : ICall, IPhoto, IVideo, IWeb
{
    public void Call()
    {
        Console.WriteLine("zenf");
    }
    public void TakePhoto()
    {
        Console.WriteLine("telfonan sekl");
    }
    public void MakeVideo()
    {
        Console.WriteLine("video cekry");
    }
    public void BrowseInternet()
    {
        Console.WriteLine("inetde axtaris");
    }
}

class Photograph
{
    public void TakePhoto(IPhoto photoMaker)
    {
        photoMaker.TakePhoto();
    }
}


#endregion