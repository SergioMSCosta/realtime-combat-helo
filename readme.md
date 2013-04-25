# Realtime Combat Helo #
This is the code for my blog post entitled "[Real-Time Combat Helo](http://sergiocosta.me/post/48857493976/real-time-combat-helo)".

This repository is comprised of 3 different applications:

- RTCH (Real Time Combat Helo): The main application which acts as a proxy between ORTC (Open Realtime Connectivity) and another application through TCP.
- RTCH-Client: a test application that connects to RTCH, sends and receives messages from it.
- RTCH-WebTest: a web page that sends receives data to and from ORTC.

By using all these apps together you should be able to send a message from RTCH-Client that is pushed to the webpage at RTCH-WebTest and vice-versa.

I hope you enjoy the post and the example. If you have any questions, doubts, corrections or ideas, please feel free to drop by my blog and contact me.

You can also find me on Twitter: @SergioMSCosta. Feel free to follow me and say Hi!

## License ##
The code here listed, unless specified by its authors, is licensed under the [Creative Commons Attribution 3.0 Unported Licence](http://creativecommons.org/licenses/by/3.0/deed.en_US).

Parts of this code were not made by me. Some of it was adapted from the example provided by [Brandon Cannaday](http://tech.pro/BrandonCannaday/blog) on his great article [C# Tutorial - Simple Threaded TCP Server](http://tech.pro/tutorial/704/csharp-tutorial-simple-threaded-tcp-server).