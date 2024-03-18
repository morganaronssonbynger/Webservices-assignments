/**
 * WebServicePA5Soap.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface WebServicePA5Soap extends java.rmi.Remote {
    public org.tempuri.CRONUS_Sverige_AB_Employee[] getEmployees() throws java.rmi.RemoteException;
    public org.tempuri.CRONUS_Sverige_AB_Employee getEmployee(java.lang.String no_) throws java.rmi.RemoteException;
    public void createEmployee(java.lang.String firstName, java.lang.String lastName, java.lang.String address, java.lang.String jobTitle) throws java.rmi.RemoteException;
    public void updateEmployee(java.lang.String no_, java.lang.String firstName, java.lang.String lastName, java.lang.String address, java.lang.String jobTitle) throws java.rmi.RemoteException;
    public void removeEmployee(java.lang.String no_) throws java.rmi.RemoteException;
}
