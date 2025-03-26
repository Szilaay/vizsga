<?php

use Illuminate\Support\Facades\Route;

use App\Http\Controllers\MainController;

Route::view('/', 'welcome');

Route::get('/main', [MainController::class, 'getMain']);

Route::get('/film/{id}', [MainController::class, 'getFilm']);

Route::get('/add', [MainController::class, 'getAdd']);
Route::post('/add', [MainController::class, 'postAdd']);

