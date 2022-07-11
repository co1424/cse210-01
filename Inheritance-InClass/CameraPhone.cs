public class CameraPhone : Phone {
    List<string> images = new List<string>();

    public CameraPhone(string phoneNumber) : base(phoneNumber){


    }

    public void takePicture() {
        images.Add("img");
        Console.WriteLine("Img has been added from the camera");
    }
}