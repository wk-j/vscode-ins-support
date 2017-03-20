#addin "nuget:?package=Cake.SquareLogo&version=0.7.0"

Task("Publish").Does(() => {
    StartProcess("vsce", new ProcessSettings {
        Arguments = "publish"
    });
});

Task("Icon").Does(() =>{
    CreateLogo("INS", "images/icon.png", new LogoSettings {
        Background = "DeepSkyBlue",
        //FontFamily = "Phosphate",
        Foreground = "White",
        Padding = 50
    });
});

var target = Argument("target", "default");
RunTarget(target);