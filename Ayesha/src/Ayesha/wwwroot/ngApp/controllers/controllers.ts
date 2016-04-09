namespace Ayesha.Controllers {

    

    export class HomeController {
        public message = 'Hello from the home page!';

        public Desserts;
        constructor($resource: ng.resource.IResourceService) {
            let resource = $resource('/api/Desserts/:id');
            this.Desserts = resource.query();
        }
       
    }




    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
