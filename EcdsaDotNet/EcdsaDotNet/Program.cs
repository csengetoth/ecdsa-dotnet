using EllipticCurve.Utils;
using EllipticCurve;

Console.WriteLine("It runs! :)");

PrivateKey privkey = new PrivateKey();
PublicKey pubkey = privkey.publicKey();

// Sign flow
string message = "Csenge's message to the World!";
string message2 = "Csenge's message to the Universe!";
Signature signature = Ecdsa.sign(message, privkey);

Console.WriteLine($" Verified? {Ecdsa.verify(message, signature, pubkey)}");
Console.WriteLine($" Verified? {Ecdsa.verify(message2, signature, pubkey)}");