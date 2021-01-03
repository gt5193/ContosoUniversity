describe('My First Test', () => {
    it('Hits a website', () => {
        cy.visit('www.google.com')
    })
    it('Does not do much!', () => {
        expect(true).to.equal(true)
    })
})