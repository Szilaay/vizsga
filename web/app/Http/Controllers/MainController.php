<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

use App\Models\film;
use App\Models\szinesz;
use App\Models\szerepek;

class MainController extends Controller
{
    public function getMain(){

        $filmek = film::select('filmid', 'cim')->orderBy('cim', 'asc')->get();

        return view('main', ['filmek' => $filmek]);
    }

    public function getFilm($id){
        $film = film::find($id);

        $szereplok = szinesz::select('szinesz.nev', 'szinesz.szuldatum', 'szinesz.nemzet', 'szerepek.szerep')
        ->join('szerepek', 'szinesz.szineszid', '=', 'szerepek.szineszid')
        ->where('szerepek.filmid', '=', $id)
        ->orderBy('szerepek.szerep', 'asc')
        ->get();
    
        return view('film', ['film' => $film, 'szereplok' => $szereplok]);
    }

    public function getAdd(){
        $randomNumber = Film::inRandomOrder()->first()->filmid;

        return view('add', ['randomNumber' => $randomNumber]);
    }

    public function postAdd(Request $req){
        $req -> validate([
            'nev' => 'required',
            'szuldatum' => 'required|date|before:today',
            'nemzete' => 'required',
        ],[
            'nev.required' => 'Kérlek add meg a nevét!',

            'szuldatum.required' => 'Kérlek add meg a születési dátumát!',
            'szuldatum.date' => 'A születési dátum nem megfelelő formátumú!',
            'szuldatum.before' => 'Mai és jövendőbeli dátum nem adható meg.',

            'nemzete.required' => 'Kérlek add meg a színész nemzetét!',
        ]);

        $szinesz = new szinesz;
        $szinesz -> nev = $req -> nev;
        $szinesz -> szuldatum = $req -> szuldatum;
        $szinesz -> nemzet = $req -> nemzete;

        $szinesz -> save();


        return view('success', [
            'nev' => $req -> nev,
            'szuldatum' => $req -> szuldatum,
            'nemzet' => $req -> nemzete,
        ]);
    }
}
