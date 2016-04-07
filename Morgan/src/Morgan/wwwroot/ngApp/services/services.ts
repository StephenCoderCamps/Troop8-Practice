namespace Morgan.Services {

    export class GuestbookService {

        private guestbookResource;

        constructor(private $resource: angular.resource.IResourceService) {

            this.guestbookResource= this.$resource('/api/Guestbooks/:id');
        }
        getGuestbooks() {

            return this.guestbookResource.query();
        }
        
    }

    angular.module('Morgan').service('guestbookService', GuestbookService );
    }
