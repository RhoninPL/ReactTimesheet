import React from "react";
import Button from 'react-bootstrap/lib/Button';
import FormGroup from 'react-bootstrap/lib/FormGroup';
import FormControl from 'react-bootstrap/lib/FormControl';
import Grid from 'react-bootstrap/lib/Grid';
import Row from 'react-bootstrap/lib/Row';
import Col from 'react-bootstrap/lib/Col';
import './Form.scss';

class Form extends React.Component {
    render() {
        return (
            <div className="form">
                <Grid>
                    <Row className="show-grid">
                        <Col xs={3} md={2}>Jan Kowalski</Col>
                        <Col xs={2} md={1}>8h</Col>
                        <Col xs={3} md={2}>Microsoft</Col>
                    </Row>
                </Grid>
                <form>
                    <FormGroup className="form-inline">
                        <FormControl type="text" id="company" placeholder="Enter company name" />
                        <FormControl type="text" id="time" placeholder="Enter time" />
                        <Button type="submit">Save</Button>
                    </FormGroup>
                </form>
            </div>
        );
    }
};

export default Form;