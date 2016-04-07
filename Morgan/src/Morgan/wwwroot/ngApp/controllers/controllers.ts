namespace Morgan.Controllers {

    export class HomeController {
        public guestbookList;
        constructor(private guestbookService : Morgan.Services.GuestbookService){
            this.guestbookList = this.guestbookService.getGuestbooks();
    }
   
    };



    export class AboutController {
        public message = 'Hello from the about page!';
    }

     

    
}
