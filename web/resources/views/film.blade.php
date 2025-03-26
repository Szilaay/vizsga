@extends('Layout.app')

@section('content')
<main class="container pb-2 fs-5">
    <h1 class="text-center display-6 pt-3">{{ $film -> cim }}</h1>
    <hr class="w-50 mx-auto">
    <div class="row">
        <div class="col-md">
            <table class="table table-bordered table-dark">
                <thead>
                    <tr>
                        <th class="text-center bg-primary" colspan="2">A film adatai</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Film címe</td>
                        <td>{{ $film -> cim }}</td>
                    </tr>
                    <tr>
                        <td>Megjelenés éve</td>
                        <td>{{ $film -> megjelenes }}</td>
                    </tr>
                    <tr>
                        <td>Műfaj</td>
                        <td>{{ $film -> mufaj }}</td>
                    </tr>
                    <tr>
                        <td>Gyártó</td>
                        <td>{{ $film -> gyarto }}</td>
                    </tr>
                    <tr>
                        <td>Megjelenés éve</td>
                        <td>{{ $film -> megjelenes }}</td>
                    </tr>
                </tbody>
            </table>

            <table class="table table-bordered table-dark mt-5">
                <thead>
                    <tr>
                        <th class="text-center bg-primary" colspan="2">Szereplők</th>
                    </tr>
                </thead>
                <tbody>
                    @foreach ($szereplok as $data)
                    <tr>
                        <td>{{ $data -> szerep }}</td>
                        <td>
                            {{ $data -> nev}}
                            <span style="font-size: 0.8em">({{ date('Y. m. d.', strtotime($data->szuldatum)) }})</span> <br>
                            <span style="font-size: 0.8em">{{ $data -> nemzet }} színész</span>
                        </td>
                    </tr>
                    @endforeach
                </tbody>
            </table>
        </div>
        <div class="col-md">
            <img src="{{ asset('assets/img/'.$film -> filmid.'.jpg') }}" class="img-fluid" alt="{{ $film -> filmid }}.jpg">
        </div>
    </div>
</main>
@endsection