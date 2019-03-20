let should = chai.should();

describe('beginning-exercises', () => {
  beforeEach(() => {
    let fixture = document.getElementById('fixture');
    fixture.insertAdjacentHTML('beforeend', `<table class="table" id="product-list">
    <thead>
        <tr>
            <th>Move</th>
            <th>Name</th>
            <th>Quantity</th>
            <th>Price</th>
        </tr>
    </thead>
    <tbody>
        <template id="row-template">
        <tr>
            <td><i class="material-icons move-up">keyboard_arrow_up</i> <i class="material-icons move-down">keyboard_arrow_down</i></td>
            <td class="name-location">Name</td>
            <td>
                <form data-price="">
                    <input type="number" value="1" name="quantity"/>
                    <button type="submit" class="update-quantity">Update Quantity</button>
                </form>
            </td>
            <td>$ <span class="price-location"></span></td>
        </tr>
        </template>
    </tbody>
    <tfoot>
        <tr>
            <td class="text-right" colspan="3">Grand Total</td>
            <td>$ <span id="grand-total"></span></td>
        </tr>
    </tfoot>
</table>
<!-- Cards for products -->
<div class="card">
    <div class="card-body">
        <h5 class="card-title">TEST PRODUCT ONE</h5>
        <a href="#" class="card-link" id="add-to-cart" data-price="1.11" data-name="TEST PRODUCT ONE">Add to Cart</a>
    </div>
</div>
<div class="card">
    <div class="card-body">
        <h5 class="card-title">TEST PRODUCT TWO</h5>
        <a href="#" class="card-link" id="add-to-cart" data-price="2.22" data-name="TEST PRODUCT TWO">Add to Cart</a>
    </div>
</div>
<div class="card">
    <div class="card-body">
        <h5 class="card-title">TEST PRODUCT THREE</h5>
        <a href="#" class="card-link" id="add-to-cart" data-price="3.33" data-name="TEST PRODUCT THREE">Add to Cart</a>
    </div>
</div>`);
  });
  afterEach(() => {
    let fixture = document.getElementById('fixture');
    fixture.innerHTML = '';
  });

  describe('addToCart', () => {
    it('should add to the cart when given a card Add To Cart link', () => {
      let cardLink = document.querySelector('#fixture .card a.card-link');
      addToCart(cardLink);

      let row = document.querySelector('#fixture table#product-list tbody > tr');
      row.querySelector('.name-location').innerText.should.equal('TEST PRODUCT ONE');
      row.querySelector('.price-location').innerText.should.equal('1.11');
    });
  });

  describe('moveRow Functions', () => {
    beforeEach(() => {
      let cardLinks = document.querySelectorAll('#fixture .card a.card-link');
      addToCart(cardLinks[0]);
      addToCart(cardLinks[1]);
      addToCart(cardLinks[2]);
    }); 
    describe('moveRowUp', () => {
      it('should move middle row up one', () => {
        let rows = document.querySelectorAll('#fixture table#product-list tbody > tr');
        rows[1].querySelector('.name-location').innerText.should.equal('TEST PRODUCT TWO');
        moveRowUp(rows[1].querySelector('i.move-up'));

        rows = document.querySelectorAll('#fixture table#product-list tbody > tr');
        rows[0].querySelector('.name-location').innerText.should.equal('TEST PRODUCT TWO');
      });

      it('should move bottom row up one', () => {
        let rows = document.querySelectorAll('#fixture table#product-list tbody > tr');
        rows[2].querySelector('.name-location').innerText.should.equal('TEST PRODUCT THREE');
        moveRowUp(rows[2].querySelector('i.move-up'));

        rows = document.querySelectorAll('#fixture table#product-list tbody > tr');
        rows[1].querySelector('.name-location').innerText.should.equal('TEST PRODUCT THREE');
      });

      it('should not move the first row up', () => {
        let rows = document.querySelectorAll('#fixture table#product-list tbody > tr');
        rows[0].querySelector('.name-location').innerText.should.equal('TEST PRODUCT ONE');
        moveRowUp(rows[0].querySelector('i.move-up'));

        rows = document.querySelectorAll('#fixture table#product-list tbody > tr');
        rows[0].querySelector('.name-location').innerText.should.equal('TEST PRODUCT ONE');
      });
    });

    describe('moveRowDown', () => {
      it('should move middle row down one', () => {
        let rows = document.querySelectorAll('#fixture table#product-list tbody > tr');
        rows[1].querySelector('.name-location').innerText.should.equal('TEST PRODUCT TWO');
        moveRowDown(rows[1].querySelector('i.move-down'));

        rows = document.querySelectorAll('#fixture table#product-list tbody > tr');
        rows[2].querySelector('.name-location').innerText.should.equal('TEST PRODUCT TWO');
      });

      it('should move top row down one', () => {
        let rows = document.querySelectorAll('#fixture table#product-list tbody > tr');
        rows[0].querySelector('.name-location').innerText.should.equal('TEST PRODUCT ONE');
        moveRowDown(rows[0].querySelector('i.move-down'));

        rows = document.querySelectorAll('#fixture table#product-list tbody > tr');
        rows[1].querySelector('.name-location').innerText.should.equal('TEST PRODUCT ONE');
      });

      it('should not move the last row down', () => {
        let rows = document.querySelectorAll('#fixture table#product-list tbody > tr');
        rows[2].querySelector('.name-location').innerText.should.equal('TEST PRODUCT THREE');
        moveRowDown(rows[2].querySelector('i.move-down'));

        rows = document.querySelectorAll('#fixture table#product-list tbody > tr');
        rows[2].querySelector('.name-location').innerText.should.equal('TEST PRODUCT THREE');
      });
    });
  });

  describe('updateQuantity', () => {
    beforeEach(() => {
      let cardLink = document.querySelector('#fixture .card a.card-link');
      addToCart(cardLink);
    });
    it('should update display price', () => {
      let row = document.querySelector('#fixture table#product-list tbody > tr');
      row.querySelector('input').value = 10;
      updateQuantity(row.querySelector('#fixture form'));

      row.querySelector('#fixture span.price-location').innerText.should.equal('11.10');
    });

    it('should remove items that have a quantity zero', () => {
      let row = document.querySelector('#fixture table#product-list tbody > tr');
      row.querySelector('input').value = 0;
      updateQuantity(row.querySelector('#fixture form'));

      row = document.querySelector('#fixture table#product-list tbody > tr');
      should.not.exist(row); 
    });

    it('should remove items that have a quantity less than zero', () => {
      let row = document.querySelector('#fixture table#product-list tbody > tr');
      row.querySelector('input').value = -1;
      updateQuantity(row.querySelector('#fixture form'));

      row = document.querySelector('#fixture table#product-list tbody > tr');
      should.not.exist(row); 
    });
  });

  describe('updateTotal', () => {
    beforeEach(() => {
      let cardLink = document.querySelector('#fixture .card a.card-link');
      addToCart(cardLink);
    });

    it('should update grand total on new row addition', () => {
      updateTotal();
      let grandTotalSpan = document.getElementById('grand-total');
      grandTotalSpan.innerText.should.equal('1.11');
 
      let cardLink = document.querySelectorAll('#fixture .card a.card-link')[1];
      addToCart(cardLink);
      updateTotal();

      grandTotalSpan.innerText.should.equal('3.33');
    });

    it('should update grand total on quantity update', () => {
      updateTotal();
      let grandTotalSpan = document.getElementById('grand-total');
      grandTotalSpan.innerText.should.equal('1.11'); 

      let row = document.querySelector('#fixture table#product-list tbody > tr');
      row.querySelector('input').value = 3;
      updateQuantity(row.querySelector('#fixture form'));
      updateTotal();

      grandTotalSpan.innerText.should.equal('3.33');
    });
  });


});