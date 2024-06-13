import { AspnetBoilerPlateMvcTest1TemplatePage } from './app.po';

describe('AspnetBoilerPlateMvcTest1 App', function() {
  let page: AspnetBoilerPlateMvcTest1TemplatePage;

  beforeEach(() => {
    page = new AspnetBoilerPlateMvcTest1TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
