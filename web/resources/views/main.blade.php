@extends('Layout.app')

@section('content')
<main class="container pb-2 fs-5">
    <div class="row pt-5">
        @foreach ($filmek as $data)
        <div class="col-12 col-md-6 col-lg-4 col-xl-3 mb-3">
            <div class="card">
                <img src="{{ asset('assets/img/'.$data -> filmid.'.jpg') }}" alt="{{ $data -> filmid }}.jpg">
                <div class="card-body">
                    <h5 class="card-title text-center"><a href="/film/{{ $data -> filmid }}">
                        {{ $data->cim }}
                        </a></h5>
                </div>
            </div>
        </div>
        @endforeach
    </div>
</main>
@endsection