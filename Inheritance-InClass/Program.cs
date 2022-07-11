// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

void main() {
    Phone phone = new Phone("5095960161");
    CameraPhone cphone = new CameraPhone("5052380304");

    phone.placeCall("5052380304");

    phone.placeText("5052380304", "Hi I love you");

    cphone.takePicture();

    cphone.placeCall("5095960161");

    cphone.placeText("5095960161", "I love you too");

}