/// <reference path="C:\Users\angel\Desktop\Prova técnica\JogoCartas\JogoPoker\Scripts/angular.js" />
var app = angular.module("GameApp", ["ngRoute"]);
var numJogadores = 2;

app.controller("GameCtrl", function ($scope, $http) {

    $scope.exibirResultado = function () {
        $scope.exibir = true;
    };

    $scope.ocultarResultado = function () {
        $scope.exibir = false;
    };

    $scope.listarJogadores = function () {

        // -- Pega o número de jogadores informado na combo
        var numJogadores = $("#jogadores").val();

        $http.post("/home/RetornaMaoJogadores", { numJogadores})
        .success(function (data) {
            $scope.MaosJogadores = data.jogadores;
            $scope.Resultado = data.resultado;
        });
    };
});

app.config(function ($routeProvider) {
    $routeProvider.when("/", { templateUrl: "/Angular_App/Pagina/Main.html" })
                  .when("/jogo", { templateUrl: "/Angular_App/Pagina/Jogo.html" })
                  .when("/jogadores", { templateUrl: "/Angular_App/Pagina/Jogadores.html" })
                  .otherwise({ redirectTo: '/' });
});