public class CameraPhone : Phone
{

    List<string> pictures = new List<string>();

    public void takePicture(string pictureName)
    {
        pictures.Add(pictureName);
    }
}