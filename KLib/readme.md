In the services builder add KLib:
```csharp
builder.Services.AddKLib();
```

In the _Imports.razor file add the following line:
```html
@using KLib.Components
```

In the index.html file (or in the App.razor depending by the project type), add the following line in the ```<head>``` section:
```html
<link id="klibcss" href="_content/KLib/klib.css" rel="stylesheet" />
```

and, if you don't have it already, add the bootstrap library (v5/5.3) following the instructions in the [Bootstrap documentation](https://getbootstrap.com/docs/5.3/getting-started/introduction/).
N.B.: Use the bootstrap package with popper, orelse integrate it.

Complete example:
```html
<head>
    ...
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link id="klibcss" href="_content/KLib/klib.css" rel="stylesheet" />
    ...
</head>
...
<script>
    ...
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
    ...
</script>
```

In certain scenarios you'll need to specify the render mode of the components. To do this, add the following line in the index.html file (or in the App.razor depending by the project type), in the ```<head>``` section:
```html
<body>
    ...
    <Routes @rendermode=RenderMode.InteractiveServer />
    ...
</body>
```
