namespace Sarah.Controllers {

    export class HomeController {
        public darthVader;
        constructor(private SithService: Sarah.Services.SithService) {
            this.darthVader = this.SithService.listSith();
        }

    }



    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
