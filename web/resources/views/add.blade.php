@extends('Layout.app')

@section('content')
<main class="container pb-2 fs-5">
    <h1 class="text-center display-6 pt-3">Színész hozzáadása</h1>
    <hr class="w-50 mx-auto">
    <div class="row">
        <div class="col-md">
            <div class="card mx-auto">
                <div class="card-body">
                    <form action="/add" method="post">
                        @csrf
                        <div class="my-2">
                            <label for="nev" class="form-label">Színész neve:</label>
                            <input type="text" name="nev" id="nev" class="form-control" value="{{ old('nev') }}">
                            @error('nev')
                                <p class="text-danger">{{ $message }}</p>
                            @enderror
                        </div>
                        <div class="my-2">
                            <label for="szuldatum" class="form-label">Színész születési dátuma:</label>
                            <input type="date" name="szuldatum" id="szuldatum" class="form-control" value="{{ old('szuldatum') }}">
                            @error('szuldatum')
                                <p class="text-danger">{{ $message }}</p>
                            @enderror
                        </div>
                        <div class="my-2">
                            <label for="nemzete" class="form-label">Színész nemzete:</label>
                            <input type="text" name="nemzete" id="nemzete" class="form-control" value="{{ old('nemzete') }}">
                            @error('nemzete')
                                <p class="text-danger">{{ $message }}</p>
                            @enderror
                        </div>
                        <button class="btn btn-primary" type="submit">Elküldés</button>
                    </form>
                </div>
            </div>
        </div>
        <div class="col-md">
            <img src="{{ asset('assets/img/'.$randomNumber.'.jpg') }}" class="img-fluid" alt="{{ $randomNumber }}.jpg">
        </div>
    </div>
</main>
@endsection