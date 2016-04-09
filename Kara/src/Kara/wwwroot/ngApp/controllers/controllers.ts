namespace Kara.Controllers {

    export class HomeController {
        public teslas;
        constructor($resource: ng.resource.IResourceService) {
            let teslaResource = $resource('/api/teslas/:id');
            this.teslas = teslaResource.query();

        }
    }



    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
