<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Movie</title>
    <!-- Bootswatch Darkly Theme  --  https://bootswatch.com/darkly/ -->
    <link rel="stylesheet" href="{{ asset('assets/css/bootstrap.css') }}">
    <link rel="stylesheet" href="{{ asset('assets/css/style.css') }}">
    <link rel="icon" type="image/x-icon" href="{{ asset('assets/img/favicon.jpg') }}">
    <script src="{{ asset('assets/js/bootstrap.bundle.js') }}"></script>
</head>
<body>
    <nav class="navbar navbar-expand-md bg-dark navbar-dark">  
        <div class="container">
            <a class="navbar-brand text-danger text-uppercase" href="\">Movie</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarColor01">
            <ul class="navbar-nav me-auto">
                <li class="nav-item">
                <a class="nav-link" href="/main">Filmek</a>
                </li>
                <li class="nav-item">
                <a class="nav-link" href="/add">Színész hozzáadása</a>
                </li>
            </ul>
            </div>
        </div>
    </nav>
    @yield('content')
    <footer class="container">
        <hr>
        <p class="text-center fs-5 py-3">Szücs Szilárd - 13.B</p>
    </footer>
</body>
</html>