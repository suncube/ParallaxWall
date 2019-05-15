## 2D like 3D

All started from idea. There was a time when game was loading scenes on mobile devices for 12 second, so long for mobile. And in order to diversify loading screen I thought to make a mini game on the loading screen. As an interaction, use an accelerometer or gyroscope device. 

After some time, I saw a [3D screensaver](https://play.google.com/store/search?q=3dwallpapers) for my android and thought about doing something similar.
By the way, you can reproduce this using samples below and this [plugin](https://assetstore.unity.com/packages/tools/integration/ulivewallpaper-indie-52110) for Unity

### Version 0

The first thing that occurred to me it's to **split image by Z** and changing **rotation by X and Y** as it turned out very easily. As a test, I tried to reproduce tree from above. 

![](/ReadmeSource/preview1.gif)

### Version 1

To reach the depth of the picture, you only need to change by increasing Z. I tried many options and the more I tried to adjust it the less I liked it. In fact, if you look closely, the coordinates on the plane are visually shifted. And the second idea was born. **Replace rotation to offset in X and Y**. 

![](/ReadmeSource/preview2.gif)

Due to the fact that the speed was the same everywhere and distances were different, some life appeared on picture.

### Version 2

I recently saw this article.([facebook 3d photos](https://www.alanzucconi.com/2019/01/01/facebook-3d-photos/))
And I tried to make the same effect for the test, but already **using a shader**. This version has the right to exist, but I prefer version 1 - because of the configuration options.

![](/ReadmeSource/preview3.gif)


**Folow me:** 

[Patreon](https://www.patreon.com/suncube)  | [Twitter](https://twitter.com/suncubestudio) | [Facebook](https://www.facebook.com/suncubestudio/) | [YouTube](https://www.youtube.com/channel/UC4O9GHjx0ovyVYJgMg4aFMA?view_as=subscriber) | [AssetStore](https://assetstore.unity.com/publishers/14506) | [GitHub](https://github.com/suncube)
