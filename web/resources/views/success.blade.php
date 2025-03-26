@extends('Layout.app')

@section('content')
<main class="container pb-2 fs-5">
    <h1 class="text-center display-6 pt-3">Sikeresen hozzáadtad!</h1>
    <hr class="w-50 mx-auto">
    <div class="text-center">
        <p>Színész neve: {{ $nev }}</p>
        <p>Színész születési dátuma: {{ $szuldatum }}</p>
        <p>Színész nemzete: {{ $nemzet }}</p>
    </div>
</main>
@endsection