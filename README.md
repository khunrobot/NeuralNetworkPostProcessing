Neural Network Post Processing
========

(This Project is Working in Progress, could be with bugs)

Post Processing for Unity using Convolution Neural Network. CNN Model trained with pix2pix/GAN, Fast Neural Style Transfer 
You can create your style offline and train the network with your own data, making your NNPP!

* Compute Shader based Neural Network Forward Pass, 10x faster than Keras
* Trainer with pix2pix or fast-style-transfer
* Keras model and weight discription to Unity

trained with Pix2Pix:
[![Pix2Pix](http://img.youtube.com/vi/qYcST5reOzY/0.jpg)](http://www.youtube.com/watch?v=qYcST5reOzY "Pix2Pix")

trained with Fast Neural Style Transfer
[![Pix2Pix](http://img.youtube.com/vi/FdhDpCHo4aU/0.jpg)](https://www.youtube.com/watch?v=FdhDpCHo4aU "FNST")

## How to Run:

Open ***HirezScene*** scene and run!

### Requirement
* Unity 2018.2+
* Compute Shader support (DX11+, Vulkan, Metal)

Reference
========

borrowed code from
* https://github.com/eriklindernoren/Keras-GAN  
* https://github.com/misgod/fast-neural-style-keras  
* https://github.com/keijiro/Pix2Pix
